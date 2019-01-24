#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_IO_Stream1273022909.h"

// System.IO.Stream
struct Stream_t1273022909;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Net.Security.AuthenticatedStream
struct  AuthenticatedStream_t3415418016  : public Stream_t1273022909
{
public:
	// System.IO.Stream System.Net.Security.AuthenticatedStream::innerStream
	Stream_t1273022909 * ___innerStream_1;
	// System.Boolean System.Net.Security.AuthenticatedStream::leaveStreamOpen
	bool ___leaveStreamOpen_2;

public:
	inline static int32_t get_offset_of_innerStream_1() { return static_cast<int32_t>(offsetof(AuthenticatedStream_t3415418016, ___innerStream_1)); }
	inline Stream_t1273022909 * get_innerStream_1() const { return ___innerStream_1; }
	inline Stream_t1273022909 ** get_address_of_innerStream_1() { return &___innerStream_1; }
	inline void set_innerStream_1(Stream_t1273022909 * value)
	{
		___innerStream_1 = value;
		Il2CppCodeGenWriteBarrier(&___innerStream_1, value);
	}

	inline static int32_t get_offset_of_leaveStreamOpen_2() { return static_cast<int32_t>(offsetof(AuthenticatedStream_t3415418016, ___leaveStreamOpen_2)); }
	inline bool get_leaveStreamOpen_2() const { return ___leaveStreamOpen_2; }
	inline bool* get_address_of_leaveStreamOpen_2() { return &___leaveStreamOpen_2; }
	inline void set_leaveStreamOpen_2(bool value)
	{
		___leaveStreamOpen_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
