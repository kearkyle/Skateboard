//****************************************************************************************************************************
//Program name: "Skateboard Animation". This is a simple animation of a moving object along one side of a triangle.                                                           *
//Copyright (C) 2020  Vong Chen                                                                                        *
//This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License  *
//version 3 as published by the Free Software Foundation.                                                                    *
//This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied         *
//warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.     *
//A copy of the GNU General Public License v3 is available here:  <https://www.gnu.org/licenses/>.                           *
//****************************************************************************************************************************

//Ruler:=1=========2=========3=========4=========5=========6=========7=========8=========9=========0=========1=========2=========3**

//Author: Vong Chen
//Mail: vchen7@csu.fullerton.edu

//Program name:  Skateboard Animation
//Programming language: C Sharp
//Date development of program began: 2020-October-18
//Date of last update: 2020-October-19
//Course ID: CPSC 223N-01
//Assignment number: 03
//Date assignment is due: 2020-October-19

//Purpose:  This program will show a ball sliding along left-side of a triangle

//Files in project:  Skatemain.cs, Skateboardui.cs

//This file's name: Skatemain.cs
//This file purpose: This file contains function draw the ui
//Date last modified: 2020-October-19
//To compile SKateboardui.cs:
//              mcs -target:library -r:System.Drawing.dll -r:System.Windows.Forms.dll -out:Skateboardui.dll Skateboardui.cs

//To compile Skatemain.cs
//                              mcs -r:System -r:System.Windows.Forms -r:Skateboardui.dll -out:Skate.exe Skatemain.cs


using System;

using System.Windows.Forms;

public class Skatemain
{
    static void Main(string[] args)
    {System.Console.WriteLine("Welcome to the main method of animated skateboard program.");
     Skateinterface skateapp = new Skateinterface();
     Application.Run(skateapp);
     System.Console.WriteLine("Main method will now shutdown");
    }
}
