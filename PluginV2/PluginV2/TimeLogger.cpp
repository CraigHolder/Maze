#include "TimeLogger.h"

int main()
{
    int x = 1;

}

void TimeLogger::ResetLogger()
{
    m_RTBC.clear();
    m_TRT = 0.0f;
}

void TimeLogger::SaveCheckpointTime(float RTBC)
{
    m_RTBC.push_back(RTBC);
    m_TRT += RTBC;
}

float TimeLogger::GetTotalTime()
{
    return m_TRT;
}

float TimeLogger::GetCheckpointTime(int index)
{
    return m_RTBC[index];
}

int TimeLogger::GetNumCheckpoints()
{
    return m_RTBC.size();
}
