using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@?$vector@E@lzham@@QEAAPEAEXZ")]
[DemangledName("public: unsigned char * __cdecl lzham::vector<unsigned char>::get_ptr(void)")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_cpjzjc
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
