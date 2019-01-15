#include "stdafx.h"
#include "MediaOperationshandler.h"

using namespace std;
using namespace VxSdk;

// Do media operation for given character.
bool ExampleRunner::LiveStreaming::MediaOperationshandler::DoOperation(char keyCode, bool isLive, bool isRecording, bool isPlaybackMode) {
    // Map the character code with operations
    // p => Play or Pause
    // z => Increase Speed
    // x => Decrease Speed
    // l -> Go to Live
    switch (keyCode) {
        case 'p':
            if (!isRecording) return false;
            PauseOrPlay();
            return true;
        case 'z':
            if (!isRecording || isLive) return false;
            IncreaseSpeed();
            return true;
        case 'x':
            if (!isRecording || isLive) return false;
            DecreaseSpeed();
            return true;
        case 'l':
            if (isPlaybackMode || !isRecording || isLive) return false;
            GoToLive();
            return true;
        default:
            break;
    }

    return false;
}

MediaController::IStream::Mode ExampleRunner::LiveStreaming::MediaOperationshandler::GetMode() const {
    if (_mediaControl == nullptr)
        return MediaController::IStream::Mode::kStopped;

    return _mediaControl->GetMode();
}

// Decrease speed and play with new speed.
void ExampleRunner::LiveStreaming::MediaOperationshandler::DecreaseSpeed() {
    // Decrease the current speed by 2
    _speed -= 2;
    // Play the stream with new speed
    bool result = _mediaControl->Play(_speed);
    // Verfify the result.
    if (result)
        cout << "Speed decreased to " << _speed;
    else
        cout << "\nFailed to decrease speed.";
    cout << "\n";
}

// Request the media control to move the stream to live.
void ExampleRunner::LiveStreaming::MediaOperationshandler::GoToLive() const {
    _mediaControl->GoToLive();
}

// Increase speed and play with new speed.
void ExampleRunner::LiveStreaming::MediaOperationshandler::IncreaseSpeed() {
    // Increase the current speed by 2
    _speed += 2;
    // Play the stream with new speed
    bool result = _mediaControl->Play(_speed);
    // Verfify the result.
    if (result)
        cout << "Speed increased to " << _speed;
    else
        cout << "\nFailed to increase speed.";
    cout << "\n";
}

// Toggle between pause and play options.
void ExampleRunner::LiveStreaming::MediaOperationshandler::PauseOrPlay() {
    if (_isPlaying) {
        // Play mode to Pause mode
        cout << "\n" << "Pausing the stream.\n";
        _mediaControl->Pause();
        _isPlaying = false;
    }
    else {
        // Pause Mode to Play mode
        cout << "\nResuming the stream.\n";
        _mediaControl->Play(_speed);
        _isPlaying = true;
    }
}
