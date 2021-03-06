﻿using NRules.Diagnostics;

namespace NRules
{
    internal interface IExecutionContext
    {
        ISessionInternal Session { get; }
        IWorkingMemory WorkingMemory { get; }
        IAgendaInternal Agenda { get; }
        IEventAggregator EventAggregator { get; }
        IIdGenerator IdGenerator { get; }
    }

    internal class ExecutionContext : IExecutionContext
    {
        public ExecutionContext(ISessionInternal session, IWorkingMemory workingMemory, IAgendaInternal agenda, IEventAggregator eventAggregator, IIdGenerator idGenerator)
        {
            Session = session;
            WorkingMemory = workingMemory;
            Agenda = agenda;
            EventAggregator = eventAggregator;
            IdGenerator = idGenerator;
        }

        public ISessionInternal Session { get; }
        public IWorkingMemory WorkingMemory { get; }
        public IAgendaInternal Agenda { get; }
        public IEventAggregator EventAggregator { get; }
        public IIdGenerator IdGenerator { get; }
    }
}