﻿namespace SignalWire.AspNet.Common
{
    /// <summary>
    /// This class can be used as the parameter on your voice action. Incoming parameters will be bound here.
    /// </summary>
    /// <remarks>http://www.SignalWire.com/docs/api/twiml/SignalWire_request</remarks>
    public class VoiceRequest : SignalWireRequest
    {
        /// <summary>
        /// A unique identifier for this call, generated by SignalWire
        /// </summary>
        public string CallSid { get; set; }

        /// <summary>
        /// A descriptive status for the call. The value is one of queued, ringing, in-progress, completed, busy, failed or no-answer
        /// </summary>
        public string CallStatus { get; set; }

        /// <summary>
        /// The version of the SignalWire API used to handle this call. For incoming calls, this is determined by the API version set on the called number. For outgoing calls, this is the API version used by the outgoing call's REST API request
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Indicates the direction of the call. In most cases this will be inbound, but if you are using Dial it will be outbound-dial
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// This parameter is set only when SignalWire receives a forwarded call, but its value depends on the caller's carrier including information when forwarding. Not all carriers support passing this information
        /// </summary>
        public string ForwardedFrom { get; set; }

        /// <summary>
        /// This parameter is set when the IncomingPhoneNumber that received the call has had its VoiceCallerIdLookup value set to true.
        /// </summary>
        public string CallerName { get; set; }

        #region Gather & Record Parameters

        /// <summary>
        /// When used with the Gather verb, the digits the caller pressed, excluding the finishOnKey digit if used.
        /// When used with the Record verb, the key (if any) pressed to end the recording or 'hangup' if the caller hung up
        /// </summary>
        public string Digits { get; set; }

        /// <summary>
        /// When used with the Gather verb, the transcribed result of the speech
        /// </summary>
        public string SpeechResult { get; set; }

        /// <summary>
        /// When used with the Gather verb, a confidence score between 0.0 and 1.0 respectively.
        /// A higher confidence score means a greater likelihood that recognized words are correct.
        /// </summary>
        public float? Confidence { get; set; }

        /// <summary>
        /// The URL of the recorded audio.  When the result of a transcription, the URL for the transcription's source recording resource.
        /// </summary>
        public string RecordingUrl { get; set; }

        /// <summary>
        /// The status of the recording. Possible values are: completed, failed.
        /// </summary>
        public string RecordingStatus { get; set; }

        /// <summary>
        /// The duration of the recorded audio (in seconds)
        /// </summary>
        public string RecordingDuration { get; set; }

        /// <summary>
        /// The number of channels in the final recording file as an integer.
        /// </summary>
        public int? RecordingChannels { get; set; }

        /// <summary>
        /// The source of the recorded audio.
        /// </summary>
        public string RecordingSource { get; set; }

        #endregion Gather & Record Parameters

        #region Transcription Parameters

        /// <summary>
        /// The unique 34 character ID of the transcription
        /// </summary>
        public string TranscriptionSid { get; set; }

        /// <summary>
        /// Contains the text of the transcription
        /// </summary>
        public string TranscriptionText { get; set; }

        /// <summary>
        /// The status of the transcription attempt: either 'completed' or 'failed'
        /// </summary>
        public string TranscriptionStatus { get; set; }

        /// <summary>
        /// The URL for the transcription's REST API resource
        /// </summary>
        public string TranscriptionUrl { get; set; }

        /// <summary>
        /// The unique 34 character ID of the recording from which the transcription was generated
        /// </summary>
        public string RecordingSid { get; set; }

        #endregion Transcription Parameters

        #region Dial Parameters

        /// <summary>
        /// The outcome of the Dial attempt. See the DialCallStatus section below for details
        /// </summary>
        public string DialCallStatus { get; set; }

        /// <summary>
        /// The call sid of the new call leg. This parameter is not sent after dialing a conference
        /// </summary>
        public string DialCallSid { get; set; }

        /// <summary>
        /// The duration in seconds of the dialed call. This parameter is not sent after dialing a conference
        /// </summary>
        public string DialCallDuration { get; set; }

        #endregion Dial Parameters

        #region SIP Parameters

        /// <summary>
        /// The SignalWire SIP Domain to which the INVITE was sent
        /// </summary>
        public string SipDomain { get; set; }

        /// <summary>
        /// The username given when authenticating the request, if Credential List is the authentication method.
        /// </summary>
        public string SipUsername { get; set; }

        /// <summary>
        /// The Call-Id of the incoming INVITE
        /// </summary>
        public string SipCallId { get; set; }

        /// <summary>
        /// The IP Address the incoming INVITE came from.
        /// </summary>
        public string SipSourceIp { get; set; }

        #endregion SIP Parameters
    }
}