using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?partial_advance@state_base@lzcompressor@lzham@@QEAAXAEBUlzdecision@23@@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state_base::partial_advance(struct lzham::lzcompressor::lzdecision const &)")]
internal static partial class partial_advance
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		unchecked
		{
			if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 0)
			{
				if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 4u)
				{
					((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
				}
				else if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 10u)
				{
					((lzham_lzcompressor_state_base*)@this)->m_cur_state -= 3;
				}
				else
				{
					((lzham_lzcompressor_state_base*)@this)->m_cur_state -= 6;
				}
			}
			else if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
			{
				int num;
				checked
				{
					num = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
				}
				if (num == 0)
				{
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
					{
						((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 9, 11);
					}
					else
					{
						((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
					}
				}
				else
				{
					switch (num)
					{
					case 1:
						swap_8qig99.Invoke(Right: (byte*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) + 4, Left: &((lzham_lzcompressor_state_base*)@this)->m_match_hist);
						break;
					case 2:
					{
						int match_hist3 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
						int num4 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num4;
						int match_hist4 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist4;
						*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist3;
						break;
					}
					default:
					{
						int match_hist = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3];
						int num2 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = num2;
						int num3 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num3;
						int match_hist2 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist2;
						*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist;
						break;
					}
					}
					((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
				}
			}
			else
			{
				int num5 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
				((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = num5;
				int num6 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
				((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num6;
				int match_hist5 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
				((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist5;
				int match_hist6 = ((lzham_CLZDecompBase*)lzdec)->m_match_hist;
				*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist6;
				((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 7, 10);
			}
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs + Get_len_wzf5xk.Invoke(lzdec);
		}
	}
}
