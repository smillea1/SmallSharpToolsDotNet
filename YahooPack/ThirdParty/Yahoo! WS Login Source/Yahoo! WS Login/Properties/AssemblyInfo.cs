﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Resources;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Yahoo! BBAuth")]
[assembly: AssemblyDescription("Yahoo! Browser Based Authentication Class")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Yahoo! Inc.")]
[assembly: AssemblyProduct("Yahoo! BBAuth")]
[assembly: AssemblyCopyright("(C) Copyright 2006 Yahoo! Inc. All rights reserved.")]
[assembly: AssemblyTrademark("Yahoo! is a registered trademark of Yahoo! Inc.")]
//[assembly: AssemblyCulture("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: NeutralResourcesLanguageAttribute("en-US")]

// Security related
[assembly: System.Net.DnsPermission(SecurityAction.RequestMinimum)]
[assembly: System.Net.WebPermission(SecurityAction.RequestMinimum)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
