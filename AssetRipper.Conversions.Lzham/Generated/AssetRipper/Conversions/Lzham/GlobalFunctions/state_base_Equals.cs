using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??8state_base@lzcompressor@lzham@@QEBA_NAEBU012@@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::state_base::operator==(struct lzham::lzcompressor::state_base const &) const")]
internal static partial class state_base_Equals
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::state_base const &")] void* rhs)
	{
		unchecked
		{
			if (((lzham_lzcompressor_state_base*)@this)->m_cur_state != ((lzham_lzcompressor_state_base*)rhs)->m_cur_state)
			{
				return false;
			}
			for (int i = 0; (uint)i < 4u; i++)
			{
				if (((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[(uint)i] != ((int*)(&((lzham_lzcompressor_state_base*)rhs)->m_match_hist))[(uint)i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
