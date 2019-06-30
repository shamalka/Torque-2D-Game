
function score::onLevelLoaded(%this){
    $SCORE = %this;

    //Reset score
    %this.leftCount = 0;
    scoreLeft.text = "Score:" SPC %this.leftCount;

    %this.rightCount = 0;
    scoreRight.text = "Score:" SPC %this.rightCount;
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

function score::incRightCount(%this){
    %timeGap = %this.getSceneTime() - $lastTime;
    echo(%timeGap);
    if(%timeGap>1){
        %this.rightCount++;
        scoreRight.text = "Score:" SPC %this.rightCount;
    }
    $lastTime = %this.getSceneTime();
}

$SCORE::timePerGame = 10;

function score::onUpdateScene(%this){
    %timeLeft = $SCORE::timePerGame - %this.getSceneTime();

    %timeLeft = mFloor(%timeLeft + 0.5);

    //time check
    if(%timeLeft < 0){
        %this.setScenePause(true);
        GuiGameOver.visible = 1;
        if(%this.leftCount > %this.rightCount){
            GuiGameOver.text = "Game Over";
            winnerText.text = "Left Wins";
        }else if(%this.leftCount == %this.rightCount){
            GuiGameOver.text = "Game Over";
            winnerText.text = "Draw";
        }else{
            GuiGameOver.text = "Game Over";
            winnerText.text = "Right Wins";
        }
        %timeLeft = 0;
    }

    GuiTimer.text = "Timer:" SPC %timeLeft;

}