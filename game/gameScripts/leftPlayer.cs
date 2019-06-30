function LeftPlayer::onLevelLoaded(%this, %scenegraph){
    $leftPlayer = %this;

    moveMap.bindCmd(keyboard, "w", "leftPlayerUp();", "leftPlayerUpStop();");
    moveMap.bindCmd(keyboard, "a", "leftPlayerLeft();", "leftPlayerLeftStop();");
    moveMap.bindCmd(keyboard, "s", "leftPlayerDown();", "leftPlayerDownStop();");
    moveMap.bindCmd(keyboard, "d", "leftPlayerRight();", "leftPlayerRightStop();");
}

function leftPlayerUp() {    
    $leftPlayer.setLinearVelocityY( -$leftPlayer.vspeed ); 
} 
 
function leftPlayerDown() {    
    $leftPlayer.setLinearVelocityY( $leftPlayer.vspeed ); 
} 
 
function leftPlayerLeft() {   
    $leftPlayer.setLinearVelocityX( -$leftPlayer.hspeed ); 
} 
 
function leftPlayerRight() {     
    $leftPlayer.setLinearVelocityX( $leftPlayer.hspeed ); 
} 
 
function leftPlayerUpStop() {    
    $leftPlayer.setLinearVelocityY( 0 ); 
} 
 
function leftPlayerDownStop() {    
    $leftPlayer.setLinearVelocityY( 0 ); 
} 
 
function leftPlayerLeftStop(){
    $leftPlayer.setLinearVelocityX( 0 ); 
} 
 
function leftPlayerRightStop() {    
    $leftPlayer.setLinearVelocityX( 0 ); 
}