﻿using Microsoft.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpcLogger.Models {
	enum AlpcEventType {
		SendMessage,
		ReceiveMessage,
		WaitForReply,
		Unwait,
		WaitForMessage
	}

	class AlpcEvent {
		internal AlpcEvent(TraceEvent evt) {
			Time = evt.TimeStamp;
			ProcessId = evt.ProcessID;
			ThreadId = evt.ThreadID;
			ProcessName = evt.ProcessName;
		}

		public AlpcEventType Type { get; set; }
		public int ProcessId { get; set; }
		public int ThreadId { get; set; }
		public string ProcessName { get; set; }
		public int MessageId { get; set; } = -1;
		public DateTime Time { get; set; }
	}
}
