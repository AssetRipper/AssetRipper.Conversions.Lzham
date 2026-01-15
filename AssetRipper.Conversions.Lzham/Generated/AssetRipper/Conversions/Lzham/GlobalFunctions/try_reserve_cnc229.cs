using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_reserve@?$vector@E@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_reserve(unsigned int)")]
[CleanName("try_reserve")]
internal static partial class try_reserve_cnc229
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_capacity)
	{
		bool result = increase_capacity_hecp7w.Invoke(@this, new_capacity, grow_hint: true, nofail: true);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
