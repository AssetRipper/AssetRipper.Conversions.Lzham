using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@?$vector@I@lzham@@QEAAPEAIXZ")]
[DemangledName("public: unsigned int * __cdecl lzham::vector<unsigned int>::get_ptr(void)")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_npwtpj
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
