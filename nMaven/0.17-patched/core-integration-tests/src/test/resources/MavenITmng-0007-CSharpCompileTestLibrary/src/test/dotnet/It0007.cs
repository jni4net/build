#region Apache License, Version 2.0
//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//
#endregion
using System;
using NUnit.Framework;

namespace NMaven.IT {

    [TestFixture]
	public class It0007 {
		[Test] 
		public void testSimple1() {
		    Assertion.AssertEquals(1, 1);
		}
		
		[Test] 
		public void testSimple2() {
		    Assertion.AssertEquals(2, 2);
		}
		
		[Test] 
		public void testTakesSomeTime() {
		    for (int i=0; i < 9999999; i++) {
		    	Assertion.AssertEquals(i+1, i+1);
		    }
		}
	}
}
