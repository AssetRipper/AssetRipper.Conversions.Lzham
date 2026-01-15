using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_push_back@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA_NAEBUoutput_symbol@symbol_codec@2@@Z")]
[DemangledName("public: bool __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::try_push_back(struct lzham::symbol_codec::output_symbol const &)")]
[CleanName("try_push_back")]
internal static partial class try_push_back_wrcwgy
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::symbol_codec::output_symbol const &")] void* obj)
	{
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_size >= (uint)((lzham_vector*)@this)->m_capacity)
			{
				bool flag = increase_capacity_8hubbd.Invoke(@this, ((lzham_vector*)@this)->m_size + 1, grow_hint: true, nofail: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			construct_vpnrgd.Invoke((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)((lzham_vector*)@this)->m_size * (nint)sizeof(lzham_sym_freq), obj);
			((lzham_vector*)@this)->m_size++;
			return true;
		}
	}
}
