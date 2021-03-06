// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueEnumeratorTest
    {
        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach01()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach02()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach03()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach04()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach05()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach06()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(-803902696, default(int))
              ;
            keyValuePairs[1] = s0;
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void InsertManyAndDoubleForEach07()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(-799801242, default(int))
              ;
            keyValuePairs[1] = s0;
            KeyValuePair<int, int> s1
               = new KeyValuePair<int, int>(-1859982080, default(int));
            keyValuePairs[2] = s1;
            this.InsertManyAndDoubleForEach<int, int>(binaryHeap, keyValuePairs);
        }

    }
}
