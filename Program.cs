// See https://aka.ms/new-console-template for more information
SayaMusicTrack sm = new SayaMusicTrack("Manchild");
sm.PrintTrackDetails();
sm.IncreasePlayCount(5);
sm.PrintTrackDetails();
for(int i = 0; i < 2150; i++)
{
    sm.IncreasePlayCount(1000000);
}
sm.PrintTrackDetails();
sm.IncreasePlayCount(100000000);

SayaMusicTrack sm2 = new SayaMusicTrack("ManchildssManchildssManchildssManchildssManchildssManchildssManchildssManchildssManchildssManchildssManchildss");
sm2.PrintTrackDetails();