/********************************************************
*                                                       *
*     Copyright (C) Microsoft. All rights reserved.     *
*                                                       *
********************************************************/

﻿// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.ManagedChess.Engine")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCulture("")]

[assembly: InternalsVisibleTo("ChessTaskScheduler, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("mchess, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.Launcher, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.Framework35Wrappers, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.Framework4Wrappers, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.ThreadingWrappers, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.MiniMPIWrappers, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]
[assembly: InternalsVisibleTo("Microsoft.ManagedChess.Base, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]

// WARNING: this may need to be redone when we get a new version of extended reflection
[assembly: InternalsVisibleTo("Microsoft.ExtendedReflection, PublicKey=002400000480000094000000060200000024000052534131000400000100010057A289398CC79CA7E46CD08C3994CA4EC229DD91D5AB4047B1BFBEF3833332BEEDAD9BEC4014CDF721177EDB24FE644B0DD95AB436D262CAC8640FC5A87082423BE9F41DB942C8D1FD622DC4B305424D4CE9BAF88FD15735B7352A70587997681D7DF9DD5635C5CEC251FC84423AB0349538BF61ECE4D8EE7A6F2D07D169B9EC")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("d18f7d0d-8dc9-4573-8009-7dc5b9ff1301")]
