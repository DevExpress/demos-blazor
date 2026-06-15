using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Services {
    enum ToolApprovalRequestState {
        Pending,
        Approved,
        Rejected
    }
    public class ToolApprovalRequestBatch {
        List<ToolApprovalRequestContent> requests;
        Dictionary<string, ToolApprovalRequestState> states = new Dictionary<string, ToolApprovalRequestState>();

        private ToolApprovalRequestState GetState(string requestId) {
            if(states.TryGetValue(requestId, out var state)) return state;

            throw new InvalidOperationException($"Request with id {requestId} not found.");
        }

        private void SetState(string requestId, ToolApprovalRequestState state) {
            if(!states.ContainsKey(requestId))
                throw new InvalidOperationException($"Request with id {requestId} not found.");

            states[requestId] = state;
        }

        public ToolApprovalRequestBatch(List<ToolApprovalRequestContent> requests) {
            this.requests = new List<ToolApprovalRequestContent>(requests);
            this.requests.ForEach(r => states[r.RequestId] = ToolApprovalRequestState.Pending);
        }

        public bool IsRequestResolved(string requestId) {
            return GetState(requestId) != ToolApprovalRequestState.Pending;
        }
        public bool IsRequestRejected(string requestId) {
            return GetState(requestId) == ToolApprovalRequestState.Rejected;
        }
        public void ApproveRequest(string requestId) {
            SetState(requestId, ToolApprovalRequestState.Approved);
        }
        public void RejectRequest(string requestId) {
            SetState(requestId, ToolApprovalRequestState.Rejected);
        }
        public List<AIContent> GenerateResponses() {
            return requests
                .FindAll(r => states[r.RequestId] != ToolApprovalRequestState.Pending)
                .Select(r => states[r.RequestId] == ToolApprovalRequestState.Approved
                    ? r.CreateResponse(true)
                    : r.CreateResponse(false, "The user rejected this operation. Confirm cancellation and reassure them no changes were made.")
                )
                .ToList<AIContent>();
        }
        public int CountPendingRequests() {
            return requests.Count(r => states[r.RequestId] == ToolApprovalRequestState.Pending);
        }
    }
}
