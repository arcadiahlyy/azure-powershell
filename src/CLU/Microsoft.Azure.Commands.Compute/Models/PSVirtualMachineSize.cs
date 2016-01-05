// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Compute.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Microsoft.Azure.Commands.Compute.Models
{
    public class PSVirtualMachineSize : PSOperation
    {
        // Gets or sets the Maximum number of data disks allowed by a VM size.
        public int? MaxDataDiskCount { get; set; }

        // Gets or sets the Memory size supported by a VM size.
        public int MemoryInMB { get; set; }

        // Gets or sets the VM size name.
        public string Name { get; set; }

        // Gets or sets the Number of cores supported by a VM size.
        public int NumberOfCores { get; set; }

        // Gets or sets the OS disk size allowed by a VM size.
        public int OSDiskSizeInMB { get; set; }

        // Gets or sets the Resource disk size allowed by a VM size.
        public int ResourceDiskSizeInMB { get; set; }
    }
}