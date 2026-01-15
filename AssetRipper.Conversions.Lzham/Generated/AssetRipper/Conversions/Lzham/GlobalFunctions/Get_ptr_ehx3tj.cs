using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ptr@?$vector@J@lzham@@QEAAPEAJXZ")]
[DemangledName("public: long * __cdecl lzham::vector<long>::get_ptr(void)")]
[CleanName("Get_ptr")]
internal static partial class Get_ptr_ehx3tj
{
	[return: NativeType("long *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
