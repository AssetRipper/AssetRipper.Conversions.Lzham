using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_reserve@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::try_reserve(unsigned int)")]
[CleanName("try_reserve")]
internal static partial class try_reserve_x9kr5x
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_capacity)
	{
		bool result = increase_capacity_g3qqmr.Invoke(@this, new_capacity, grow_hint: true, nofail: true);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
