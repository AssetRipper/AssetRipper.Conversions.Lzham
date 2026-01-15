using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?construct_array@?$scalar_type@I@lzham@@SAXPEAII@Z")]
[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned int>::construct_array(unsigned int *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_2kyzh4
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int *")] void* p, [NativeType("unsigned int")] int n)
	{
		llvm_memset_p0_i64.Invoke(p, 0, unchecked(4L * (long)(uint)n), isVolatile: false);
	}
}
