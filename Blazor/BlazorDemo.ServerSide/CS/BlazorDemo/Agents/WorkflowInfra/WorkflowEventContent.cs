using System;
using Microsoft.Agents.AI.Workflows;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Agents.WorkflowInfra {
    public sealed class WorkflowEventContent : AIContent {
        public WorkflowEventContent(WorkflowEvent workflowEvent) {
            WorkflowEvent = workflowEvent ?? throw new ArgumentNullException(nameof(workflowEvent));
            RawRepresentation = workflowEvent;
        }

        public WorkflowEvent WorkflowEvent { get; }

        public string EventType => WorkflowEvent.GetType().Name;

        public override string ToString() => EventType;
    }
}
