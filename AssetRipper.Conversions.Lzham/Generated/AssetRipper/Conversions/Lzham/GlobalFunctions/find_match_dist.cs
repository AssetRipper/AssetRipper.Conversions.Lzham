using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?find_match_dist@state@lzcompressor@lzham@@QEBAHI@Z")]
[DemangledName("public: int __cdecl lzham::lzcompressor::state::find_match_dist(unsigned int) const")]
internal static partial class find_match_dist
{
	[return: NativeType("int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int match_dist)
	{
		unchecked
		{
			for (int i = 0; (uint)i < 4u; i++)
			{
				if (match_dist == ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[(uint)i])
				{
					return i;
				}
			}
			return -1;
		}
	}
}
