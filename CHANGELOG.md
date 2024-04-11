## GetScaleIndex Changelog
[![GetScaleIndex](https://img.shields.io/nuget/v/GetScaleIndex.svg)](https://www.nuget.org/packages/GetScaleIndex/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [1.0.0-alpha.7]
#### Added
* `ApplyScale<T>(T[] array, int width, int height, int customScale)` method is added.
* `AppleScale<T>(T[] array, int width, int height, int customScale, ParallelOptions parallelOptions)` method is added.

### [1.0.0-alpha.6]
#### Changed
* Fixing a bug on calculation of offset value on `GetCustomScaleIndex(int index, int width, int height, int customScale)` method.

### [1.0.0-alpha.5]
#### Added
* `ApplyScale<T>(List<T> list, int width, int height, int customScale)` method is added for generic list of generic data type.
* `width` and `height` values should be same for `ApplyScale<T>()` and `GetCustomScalingIndex()` methods. Temporarily value checking is added.

#### Changed
* `GetIndexFor4x(int index)` renamed as `GetScalingIndexFor4x(int index)`
* Variables renamed to enhance readability.

### [1.0.0-alpha.4]
#### Changed
* New design README.
* New design CHANGELOG.

### [1.0.0-alpha.3]
#### Added
* Added CHANGELOG.
* Added Nuget download link on README.
* Added CHANGELOG link under Version History on README.

### [1.0.0-alpha.2]
#### Added
* Added minimum value checking into `SetHeight()` and `SetWidth()` methods. 

### [1.0.0-alpha.1]
#### Added
* Added licence file.
* Readme file is filled.
* Added multi-target framework support added.
* Added summaries into methods.
* Icons are added for package and file.

### [1.0.0-alpha]
* Initial release. 