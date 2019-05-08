#!/bin/sh
#************************************************************************
# Script to claim a Plex Media Server
# Will prompt for:
#     * plex.tv username
#     * plex.tv password
#     * IP Address of your unclaimed Plex Media Server
#
# Made by dane22, a Plex community member
# Mark Walker/ZiGGiMoN, a Plex hobbyist
#
# Version: 1.1.0.0
#
# Home: https://github.com/ukdtom/ClaimIt
#************************************************************************

#************************************************************************
# Functions
#************************************************************************

function ComparePwd()
# Compare password entered
{
  if [ $passvar == $passvar2 ]
    then
      return 0
   else
     echo "Password mismatch"
     exit 1 # terminate and indicate error
  fi
}

function ValidateIP()
# Check if IP has valid format
{
  if [ "`echo $ippms | awk -F'.' 'NF==4 && $1 > 0 && $1<256 && $2<256 && $3<256 && $4<256 && !/\.\./'`" == "$ippms" ]
    then
      if  echo "$ippms" | grep -Eq '(^127\.0\.0\.1)|(^10\.)|(^172\.1[6-9]\.)|(^172\.2[0-9]\.)|(^172\.3[0-1]\.)|(^192\.168\.)' >/dev/null; then
         return 0
      else
         echo "The IP address entered is not in Private Address Space"
         echo "Either '127.0.0.1' or an address in private address space is needed to claim a server"
         echo "See: https://github.com/ukdtom/ClaimIt/wiki/IP-Address-requirement"
         exit 1
      fi
      return 0
    else
      echo "IP is not valid"
      exit 1 # terminate and indicate error
   fi
}

function GetClaimToken()
#*****************************************
#* Get claim token from plex.tv
#* Needs the following params:
#* 1 Param: X-Plex-Token
#* 2 Param: X-Plex-Client-Identifier
#*****************************************
{
  url="https://plex.tv/api/claim/token?X-Plex-Token=$1&X-Plex-Client-Identifier=ClaimIt-$2"
  local response=$(curl -i -k -L -s $url)
  # Grap the token
  local claimtoken=$(printf %s "$response" | awk -F= '$1=="token"{print $2}' RS=' '| cut -d '"' -f 2)
  # grap the return code
  local http_status=$(echo "$response" | grep HTTP |  awk '{print $2}')
  if [ -z "$http_status" ];
  then
     exit 1
  else
    if [ $http_status -eq "200" ]
      then
        echo "$claimtoken"
        exit 0
      else
       exit 1
    fi
  fi   
}

function GetLoginToken()
#*****************************************
#* Get user auth token from plex.tv
#* Needs the following params:
#* 1 Param: UserName
#* 2 Param: Password
#* 3 Param: X-Plex-Client-Identifier
#*****************************************
{
  url="https://plex.tv/api/v2/users/signin?login=$1&password=$2&X-Plex-Client-Identifier=ClaimIt-$3"
  local response=$(curl -X POST -i -k -L -s $url)
  # Grap the token
  local UserToken=$(printf %s "$response" | awk -F= '$1=="authToken"{print $2}' RS=' '| cut -d '"' -f 2)
  # grap the return code
  local http_status=$(echo "$response" | grep HTTP |  awk '{print $2}')
  if [ -z "$http_status" ];
  then 
     exit 1
  else
    if [ "$http_status" -lt "202" ]
      then
        echo "$UserToken"
      else
       exit 1
    fi
  fi
}

function GetClientIdentifier()
# Get PMS machineIdentifier
{
  url="http://$ippms:32400/identity"
  content=$(curl -i -k -L -s $url)
  local machineIdentifier=$(printf %s "$content" | awk -F= '$1=="machineIdentifier"{print $2}' RS=' '| cut -d '"' -f 2)
  local http_status=$(echo "$content" | grep HTTP |  awk '{print $2}')
  if [ -z "$http_status" ];
  then 
     exit 1
  else
    if [ $http_status -eq "200" ]
      then
          if [ -z "$machineIdentifier" ];
          then          
            exit 1
          else
            echo "$machineIdentifier"
          fi
      else
       exit 1
    fi
  fi  
}

function Claimit()
#*****************************************
#* Claim a PMS Server
#* Needs the following params:
#* 1 Param: $ippms
#* 2 Param: $XPlexClaimtoken
#* 3 Param: $XPlexClientIdentifier
#* 4 Param: $UserToken
#*****************************************
{
  url="http://$1:32400/myplex/claim?token=$2&X-Plex-Client-Identifier=ClaimIt-$3&X-Plex-Token=$4"
  content=$(curl -X POST -i -k -L -s $url)
  local http_status=$(echo "$content" | grep HTTP |  awk '{print $2}')
  if [ -z "$http_status" ];
  then
    echo "Fatal error happened"
    echo "HTTP returned Status $http_status" 
    exit 1
  else
    if [ $http_status -eq "200" ];
    then
      echo "Claiming server ok $http_status"
      echo ""
      echo ""
      echo "Please close your browser, reopen, and browse to http://$1:32400/web"
      exit 0
    else
      echo "Fatal error happened"
      echo "HTTP returned Status $http_status" 
      exit 1
    fi   
  fi  
}

#************************************************************************
#* Main
#************************************************************************
clear

echo "************************************************************************"
echo "* Script to claim a Plex Media Server"
echo "* Will prompt for"
echo "*     * plex.tv username"
echo "*     * plex.tv password"
echo "*     * IP Address of your unclaimed Plex Media Server"
echo "*"
echo "*"
echo "* Made by dane22, a Plex community member"
echo "* And Mark Walker/ZiGGiMoN, a Plex hobbyist"
echo "*"
echo "* Version 1.1.0.0"
echo "*"
echo "* To see the manual, please visit https://github.com/ukdtom/ClaimIt/wiki"
echo "************************************************************************"

read -p 'plex.tv Username: ' uservar
echo ''
read -sp 'plex.tv Password: ' passvar
echo ''
read -sp 'plex.tv Password Repeated: ' passvar2
echo ''
read -p 'IP Address of PMS server: ' ippms

# Compare pwd entered
echo "Comparing entered passwords"
ComparePwd
echo "Comparing entered passwords ok"

echo "Validating IP address"
if ! CheckIPValidity=$(ValidateIP);
then
  echo "******** ERROR ********"
  echo "The IP address entered is not in Private Address Space"
  echo "Either '127.0.0.1' or an address in private address space is needed to claim a server"
  echo "See: https://github.com/ukdtom/ClaimIt/wiki/IP-Address-requirement"
  exit 1
fi

echo "Getting PMS Server Identifier"
if ! XPlexClientIdentifier=$(GetClientIdentifier);
then
  echo "******** ERROR ********"
  echo "We failed to get the Plex Media Server ID"
  echo "Please check server is up and running, as well as the IP address entered"
  exit 1
fi
echo "Getting PMS Server Identifier ok"

# Get UserToken from plex.tv
echo "Getting User Token from plex.tv"
if ! UserToken=$(GetLoginToken "$uservar" "$passvar" "$XPlexClientIdentifier");
then
  echo "******** ERROR ********"
  echo "We failed to authenticate towards plex.tv"
  echo "Please check username and password, as well as network access"
  exit 1
fi
echo "Getting User Token from plex.tv ok"

# Get the Claim token
echo "Getting PMS Claim Token"
if ! XPlexClaimtoken=$(GetClaimToken "$UserToken" "$XPlexClientIdentifier");
then
  echo "******** ERROR ********"
  echo "We failed to get a claim token from plex.tv"
  echo "Please check username and password, as well as network access"
  exit 1
fi
echo "Getting PMS Claim Token ok"

# Claiming server
echo "Claiming server"
Claimit "$ippms" "$XPlexClaimtoken" "$XPlexClientIdentifier" "$UserToken"
