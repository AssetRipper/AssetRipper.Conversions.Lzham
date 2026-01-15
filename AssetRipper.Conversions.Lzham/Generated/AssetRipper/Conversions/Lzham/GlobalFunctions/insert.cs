using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?insert@?$vector@E@lzham@@QEAA_NIPEBEI@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::insert(unsigned int, unsigned char const *, unsigned int)")]
internal static partial class insert
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int index, [NativeType("unsigned char const *")] void* p, [NativeType("unsigned int")] int n)
	{
		if (n == 0)
		{
			return true;
		}
		unchecked
		{
			int size = ((lzham_vector*)@this)->m_size;
			bool flag = try_resize_m9x9dy.Invoke(@this, ((lzham_vector*)@this)->m_size + n, grow_hint: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			int num = size - index;
			if (num != 0)
			{
				llvm_memmove_p0_p0_i64.Invoke((byte*)((lzham_vector*)@this)->m_p + (uint)index + (uint)n, (byte*)((lzham_vector*)@this)->m_p + (uint)index, 1L * (long)(uint)num, isVolatile: false);
			}
			llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_vector*)@this)->m_p + (uint)index, p, 1L * (long)(uint)n, isVolatile: false);
			return true;
		}
	}
}
