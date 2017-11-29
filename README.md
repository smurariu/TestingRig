# TestingRig
Simple utility to measure execution times.

|Build/Package|Status|
|------|-------------|
|master|[![Build status](https://ci.appveyor.com/api/projects/status/qr5oqxela97idix7?svg=true)](https://ci.appveyor.com/project/smurariu2/testingrig)|

Allows you to write stuff like:
```cs
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
