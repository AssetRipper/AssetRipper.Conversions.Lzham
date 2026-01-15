using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?construct_array@?$scalar_type@G@lzham@@SAXPEAGI@Z")]
[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned short>::construct_array(unsigned short *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_rfafyp
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned short *")] void* p, [NativeType("unsigned int")] int n)
	{
		llvm_memset_p0_i64.Invoke(p, 0, unchecked(2L * (long)(uint)n), isVolatile: false);
	}
}
