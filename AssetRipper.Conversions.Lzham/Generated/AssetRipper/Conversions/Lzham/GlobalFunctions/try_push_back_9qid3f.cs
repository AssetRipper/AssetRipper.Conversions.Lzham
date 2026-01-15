using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_push_back@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA_NAEBUlzpriced_decision@lzcompressor@2@@Z")]
[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::try_push_back(struct lzham::lzcompressor::lzpriced_decision const &)")]
[CleanName("try_push_back")]
internal static partial class try_push_back_9qid3f
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::lzpriced_decision const &")] void* obj)
	{
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_size >= (uint)((lzham_vector*)@this)->m_capacity)
			{
				bool flag = increase_capacity_kdjynu.Invoke(@this, ((lzham_vector*)@this)->m_size + 1, grow_hint: true, nofail: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			construct_xrxbj7.Invoke((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)((lzham_vector*)@this)->m_size * (nint)sizeof(lzham_lzcompressor_lzpriced_decision), obj);
			((lzham_vector*)@this)->m_size++;
			return true;
		}
	}
}
