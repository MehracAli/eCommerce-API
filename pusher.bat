set /p commit=""


call git add .
call git commit -am "%commit%"
call git push
pause