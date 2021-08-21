echo First remove old binary files
rm *.dll
rm *.exe

echo View the list of source files
ls -l

echo Compile Skateboardui.cs to create the file: Skateboardui.dll
mcs -target:library -r:System.Drawing.dll -r:System.Windows.Forms.dll -out:Skateboardui.dll Skateboardui.cs

echo Compile Skatemain.cs and link the two previously created dll files to create an executable file. 
mcs -r:System -r:System.Windows.Forms -r:Skateboardui.dll -out:Skate.exe Skatemain.cs

echo View the list of files in the current folder
ls -l

echo Run the Assignment 1 program.
./Skate.exe

echo The script has terminated.
