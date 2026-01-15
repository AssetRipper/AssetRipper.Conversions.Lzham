using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?append@?$vector@E@lzham@@QEAA_NPEBEI@Z")]
[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::append(unsigned char const *, unsigned int)")]
[CleanName("append")]
internal static partial class append_tcvg7j
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char const *")] void* p, [NativeType("unsigned int")] int n)
	{
		if (n != 0)
		{
			bool result = insert.Invoke(@this, unchecked((lzham_vector*)@this)->m_size, p, n);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
		return true;
	}
}
