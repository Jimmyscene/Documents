#!/bin/sh
SHORTCUT="[Desktop Entry] 
Name=Sublime Text 3
Comment=Edit text files
Exec=/opt/sublime-text-3/sublime_text %f
Icon=/opt/sublime-text-3/Icon/128x128/sublime-text.png
StartupWMClass=Sublime_text
Terminal=false
Type=Application
Encoding=UTF-8
Categories=Utility;TextEditor;"
SCRIPT="#!/bin/sh
if [ \"\$1\" = \"--help\" ]; then
/opt/sublime-text-3/sublime_text --help
else
/opt/sublime-text-3/sublime_text \$@ > /dev/null 2>&1 &
fi"
curl -L "http://c758482.r82.cf2.rackcdn.com/sublime_text_3_build_3065_x64.tar.bz2" -o "/usr/src/Sublime Text 3.tar.bz2"
cd /usr/src
tar -xvjf "Sublime Text 3.tar.bz2"
cd sublime_text_3
mkdir -pv "/opt/sublime-text-3"
mv -fv * "/opt/sublime-text-3"
echo "${SCRIPT}" > "/usr/local/bin/subl"
chmod +x "/usr/local/bin/subl"
echo "${SHORTCUT}" > "/.local/share/applications/sublime-text-3.desktop"
ln -s /opt/sublime-test-3/sublime_text /usr/bin/subl

echo "Finish!"
