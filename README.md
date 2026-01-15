# AssetRipper.Conversions.Lzham

A translation of [lzham](https://github.com/richgel999/lzham_codec) to C#.

## C++ compilation

```
cmake -G "Ninja" -B out -DCMAKE_C_COMPILER=clang -DCMAKE_CXX_COMPILER=clang++ -DCMAKE_C_FLAGS="-DNOMINMAX -DNDEBUG" -DCMAKE_CXX_FLAGS="-DNOMINMAX -DNDEBUG" -DCMAKE_EXPORT_COMPILE_COMMANDS=ON
```

Then use the LargeProjectCompiler on `compile_commands.json` in the `out` folder.

### Changes from original

* Bump `cmake_minimum_required` to 3.5 in all `CMakeLists.txt` since 2.8 is not supported by modern CMake.
* In the root `CMakeLists.txt`, remove `add_subdirectory(lzhamtest)`.
* Delete `#define LZHAM_FORCE_DEBUGGER_PRESENT 1` in `lzham_platform.cpp`.
* In `lzham_mem.cpp`, delete the lines starting with `#define _msize`.
* Delete functions and calls to them:
  * `lzham_is_debugger_present`
  * `lzham_debug_break`
  * `lzham_trace` (both overloads)
