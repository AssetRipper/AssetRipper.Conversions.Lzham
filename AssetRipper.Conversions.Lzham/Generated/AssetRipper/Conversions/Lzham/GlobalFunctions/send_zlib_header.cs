using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?send_zlib_header@lzcompressor@lzham@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::send_zlib_header(void)")]
internal static partial class send_zlib_header
{
	private partial struct LocalVariables
	{
		public sbyte field_0;

		public sbyte field_1;

		public sbyte field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		localsPointer->field_1 = 0;
		localsPointer->field_2 = 0;
		bool flag;
		unchecked
		{
			if ((((lzham_lzcompressor*)@this)->field_1.m_lzham_compress_flags & 0x20) == 0)
			{
				flag = true;
			}
			else
			{
				int num = 0xE | (((lzham_lzcompressor*)@this)->field_1.m_dict_size_log2 - 15 << 4);
				int num2;
				switch (((lzham_lzcompressor*)@this)->field_1.m_compression_level)
				{
				case 0:
					num2 = 0;
					break;
				case 1:
					num2 = 64;
					break;
				case 2:
				case 3:
					num2 = 128;
					break;
				default:
					num2 = 192;
					break;
				}
				if (((lzham_lzcompressor*)@this)->field_1.m_pSeed_bytes != null)
				{
					num2 |= 0x20;
				}
				int num3 = checked((num << 8) + num2) % 31;
				if (num3 != 0)
				{
					num2 = checked(num2 + (31 - num3));
				}
				lzham_vector* field_ = &((lzham_lzcompressor*)@this)->field_9;
				localsPointer->field_0 = (sbyte)num;
				bool flag2 = try_push_back_myg3iw.Invoke(field_, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (((flag2 ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
				{
					flag = false;
				}
				else
				{
					lzham_vector* field_2 = &((lzham_lzcompressor*)@this)->field_9;
					localsPointer->field_1 = (sbyte)num2;
					bool flag3 = try_push_back_myg3iw.Invoke(field_2, &localsPointer->field_1);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (((flag3 ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
					{
						flag = false;
					}
					else
					{
						if (((lzham_lzcompressor*)@this)->field_1.m_pSeed_bytes != null)
						{
							int num4 = adler32.Invoke(buflen: (uint)((lzham_lzcompressor*)@this)->field_1.m_num_seed_bytes, pBuf: ((lzham_lzcompressor*)@this)->field_1.m_pSeed_bytes, adler32: 1);
							int num5 = 0;
							while ((uint)num5 < 4u)
							{
								lzham_vector* field_3 = &((lzham_lzcompressor*)@this)->field_9;
								localsPointer->field_2 = (sbyte)(num4 >>> 24);
								bool flag4 = try_push_back_myg3iw.Invoke(field_3, &localsPointer->field_2);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								if (((flag4 ? 1u : 0u) ^ 0xFFFFFFFFu) == 0)
								{
									num4 <<= 8;
									num5++;
									continue;
								}
								goto IL_01f9;
							}
						}
						flag = true;
					}
				}
			}
			goto IL_0213;
		}
		IL_01f9:
		flag = false;
		goto IL_0213;
		IL_0213:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
