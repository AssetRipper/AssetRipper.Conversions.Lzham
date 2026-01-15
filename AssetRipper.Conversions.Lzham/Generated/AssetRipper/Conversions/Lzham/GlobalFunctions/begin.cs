using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?begin@?$vector@G@lzham@@QEAAPEAGXZ")]
[DemangledName("public: unsigned short * __cdecl lzham::vector<unsigned short>::begin(void)")]
internal static partial class begin
{
	[return: NativeType("unsigned short *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((lzham_vector*)@this)->m_p;
	}
}
