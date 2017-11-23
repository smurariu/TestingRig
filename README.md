# TestingRig
Simple utility to measure execution times.

Allows you to write stuff like:
```
  var testResults = TestingRig.Do.ABTest(
                a: () => { IEnumerable<int> e = new List<int> { 42 }; },
                b: () => { IEnumerable<int> e = new[] { 42 }; });
```

and get output like:
```
Elapsed microseconds: 1795
Elapsed microseconds: 357
```

Simple.

Small.

And probably useless :)
