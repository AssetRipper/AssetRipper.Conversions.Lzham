using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?empty@?$vector@E@lzham@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::empty(void) const")]
internal static partial class empty
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((byte)(((((lzham_vector*)@this)->m_size != 0) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
