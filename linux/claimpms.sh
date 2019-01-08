#!/bin/sh
#************************************************************************
#* Script to claim a Plex Media Server
#* Will prompt for:
#*     * plex.tv username
#*     * plex.tv password
#*     * IP Address of your unclaimed Plex Media Server
#*
#*
#*
#*
#* Made by dane22, a Plex community member
#************************************************************************

# Start with some functions
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

function GetClaimToken()
# Get claim token from plex.tv
{
  echo "Get claim token"
}

function GetClientIdentifier()
# Get PMS machineIdentifier
{
  url="$ippms:32400/identity"
  content=$(curl -i -k -L -s $url)
  local machineIdentifier=$(printf %s "$content" | awk -F= '$1=="machineIdentifier"{print $2}' RS=' '| cut -d '"' -f 2)
  local http_status=$(echo "$content" | grep HTTP |  awk '{print $2}')
  if [ -z "$http_status" ];
  then 
     echo "Error"
     exit 1
  else

    if [ $http_status -eq "200" ]
      then
        echo "$machineIdentifier"
      else
       echo "Error"
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
echo "#*     * plex.tv username"
echo "#*     * plex.tv password"
echo "#*     * IP Address of your unclaimed Plex Media Server"
echo "#*"
echo "#*"
echo "#*"
echo "#*"
echo "#* Made by dane22, a Plex community member"
echo "#************************************************************************"



#read -p 'plex.tv Username: ' uservar
echo ''
#read -sp 'plex.tv Password: ' passvar
echo ''
#read -sp 'plex.tv Password Repeated: ' passvar2
echo ''
#read -p 'IP Address of PMS server: ' ippms

ippms="192.168.1.12"


echo ''
echo ''
echo ''

# Compare pwd entered
echo "Comparing entered passwords"
ComparePwd
echo "passwords identical"
# Get PMS Client Identifier, and eject if error
echo "Getting PMS identifier"
XPlexClientIdentifier=$(GetClientIdentifier)
if [[ $XPlexClientIdentifier == Error* ]];
then
  echo "Error contacting your Plex Media Server"
  echo "Please verify IP Address, firewall, as well as your Plex Media Server is up and running"
  exit 1
else
  echo "Retrieved PMS identifier ok"
fi


GetClaimToken




claimurl="https://$ippms:32400/myplex/claim?token=<TOKEN_FROM_https://www.plex.tv/claim/>&X-Plex-Product=Plex%20Web&X-Plex-Version=3.81.0&X-Plex-Client-Identifier=$XPlexClientIdentifier&X-Plex-Platform=Chrome&X-Plex-Platform-Version=71.0&X-Plex-Sync-Version=2&X-Plex-Device=Linux&X-Plex-Device-Name=Chrome&X-Plex-Device-Screen-Resolution=1920x913%2C1920x1080&X-Plex-Token=XXXXXXXXXXXXXXXXX&X-Plex-Language=en"


# echo $claimurl






