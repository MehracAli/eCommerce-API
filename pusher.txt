@echo off
echo Enter commit message:
set /p commit=

git add .
git commit -m "%commit%"
git push origin main

pause

