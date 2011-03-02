#region (c) 2010 Lokad Open Source - New BSD License 

// Copyright (c) Lokad 2010, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

using Lokad.Cqrs.Durability;

namespace Lokad.Cqrs.Dispatch
{
	/// <summary>
	/// Generic message dispatch interface
	/// </summary>
	public interface IMessageDispatcher
	{
		void DispatchMessage(MessageEnvelope message);
		void Init();
	}
}