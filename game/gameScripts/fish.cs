function Fish::onLevelLoaded(%this, %scenegraph){
    $fish = %this;

    %this.startPosition = this.getPosition();
    %this.setLinearVelocity(%this.hSpeed, %this.vSpeed);
}

function Fish::onCollision(%srcObj, %dstObj, %srcRef, %dstRef, %time, %normal, %contactCount, %contacts){
    if(%dstObj.class $= "LeftPlayer"){
        $SCORE.incLeftCount();
        %srcObj.bounce();
        //scoreLeft.text = "Game Over";
    }
    if(%dstObj.class $= "RightPlayer"){
        $SCORE.incRightCount();
        %srcObj.bounce();
        //scoreLeft.text = "Game Over";
    }
}

function Fish::bounce(%this){
    %this.hspeed = -%this.hspeed;
    %this.setLinearVelocity(%this.hSpeed, %this.vSpeed);
}

function Fish::onWorldLimit(%this, %mode, %limit){
    if(%limit $= "bottom" || %limit $= "top"){
        %this.vSpeed = -%this.vSpeed;
    }
}