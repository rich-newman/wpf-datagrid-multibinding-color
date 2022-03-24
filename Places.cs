// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace DataTrigger
{
    public class Places : ObservableCollection<Place>
    {
        public Places()
        {
            Add(new Place("Bellevue", "WA", 1, 1));
            Add(new Place("Gold Beach", "OR", 2, 2));
            Add(new Place("Kirkland", "WA", 3, 4));
            Add(new Place("Los Angeles", "CA", 4, 5));
            Add(new Place("Portland", "ME", 4, 5));
            Add(new Place("Portland", "OR", 4, 5));
            Add(new Place("Redmond", "WA", 4, 5));
            Add(new Place("San Diego", "CA", 4, 5));
            Add(new Place("San Francisco", "CA", 4, 5));
            Add(new Place("San Jose", "CA", 5, 5));
            Add(new Place("Seattle", "WA", 4, 5));
        }
    }
}