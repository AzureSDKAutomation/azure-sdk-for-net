// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.Hadoop.Client")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Microsoft.Hadoop.Client")]
[assembly: AssemblyCopyright("Copyright �  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguage("en-US")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("966aa1cb-d60b-4bc3-9d93-af54bdd14cee")]

// NOTE: IMPORTANT: CRITICAL: Do not ever make this assembly InternalsVisibleTo the CmdLet project.  If functionality is needed for that project it must be public here!
// harshiam // harshiam #if SIGNED                                                         
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=00240000048000009400000006020000002400005253413100040000010001009f7a95086500f8f66d892174803850fed9c22225c2ccfff21f39c8af8abfa5415b1664efd0d8e0a6f7f2513b1c11659bd84723dc7900c3d481b833a73a2bcf1ed94c16c4be64d54352c86956c89930444e9ac15124d3693e3f029818e8410f167399d6b995324b635e95353ba97bfab856abbaeb9b40c9b160070c6325e22ddc")]
[assembly: InternalsVisibleTo("Microsoft.WindowsAzure.Management.HDInsight, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
[assembly: InternalsVisibleTo("Microsoft.WindowsAzure.Management.HDInsight.TestUtilities, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
[assembly: InternalsVisibleTo("Microsoft.HadoopAppliance.Client, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
//#else
//[assembly: InternalsVisibleTo("Microsoft.WindowsAzure.Management.HDInsight")]
//[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
//[assembly: InternalsVisibleTo("Microsoft.WindowsAzure.Management.HDInsight.TestUtilities")]
//[assembly: InternalsVisibleTo("Microsoft.HadoopAppliance.Client")]
//#endif
