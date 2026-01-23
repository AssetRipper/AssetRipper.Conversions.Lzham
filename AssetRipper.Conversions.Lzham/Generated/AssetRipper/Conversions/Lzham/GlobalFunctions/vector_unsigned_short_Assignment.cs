using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4?$vector@G@lzham@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class lzham::vector<unsigned short> & __cdecl lzham::vector<unsigned short>::operator=(class lzham::vector<unsigned short> const &)")]
internal static partial class vector_unsigned_short_Assignment
{
	[return: NativeType("class lzham::vector<unsigned short> &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::vector<unsigned short> const &")] void* other)
	{
		if (@this == other)
		{
			return @this;
		}
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_capacity >= (uint)((lzham_vector*)other)->m_size)
			{
				try_resize_x6c5v6.Invoke(@this, 0, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
			}
			else
			{
				clear_nj6f5j.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				bool flag = increase_capacity_dwbww2.Invoke(@this, ((lzham_vector*)other)->m_size, grow_hint: false, nofail: false);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				if (!flag)
				{
					lzham_fail.Invoke(String_e4f6vd.Pointer, String_cn9etx.Pointer, 96);
					return @this;
				}
			}
			llvm_memcpy_p0_p0_i64.Invoke(((lzham_vector*)@this)->m_p, ((lzham_vector*)other)->m_p, (long)(uint)((lzham_vector*)other)->m_size * 2L, isVolatile: false);
			((lzham_vector*)@this)->m_size = ((lzham_vector*)other)->m_size;
			return @this;
		}
	}
}
