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

function GetClientIdentifier()
{
  url="$ippms:32400/identity"
  content=$(wget -qO- $url)
  local machineIdentifier=$(printf %s "$content" | awk -F= '$1=="machineIdentifier"{print $2}' RS=' '| cut -d '"' -f 2)
  echo "$machineIdentifier"
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



read -p 'plex.tv Username: ' uservar
echo ''
read -sp 'plex.tv Password: ' passvar
echo ''
read -sp 'plex.tv Password Repeated: ' passvar2
echo ''
read -p 'IP Address of PMS server: ' ippms

ippms="192.168.1.12"
echo ''
echo ''
echo ''

ComparePwd
echo "The end $(GetClientIdentifier)"






