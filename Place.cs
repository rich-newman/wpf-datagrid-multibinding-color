// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DataTrigger
{
    public class Place
    {
        public Place(string name, string state, int prop1, int prop2)
        {
            Name = name;
            State = state;
            Prop1 = prop1;
            Prop2 = prop2;
        }

        public string Name { get; set; }
        public string State { get; set; }
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}