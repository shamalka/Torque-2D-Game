
function score::onLevelLoaded(%this){
    $SCORE = %this;

    //Reset score
    %this.leftCount = 0;
    scoreLeft.text = "Score:" SPC %this.leftCount;
}

function score::incLeftCount(%this){
    %timeGap = %this.getSceneTime() - $lastTime;
    echo(%timeGap);
    if(%timeGap>1){
        %this.leftCount++;
        scoreLeft.text = "Score:" SPC %this.leftCount;
    }
    $lastTime = %this.getSceneTime();
}