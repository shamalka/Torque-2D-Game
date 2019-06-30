function RightPlayer::onLevelLoaded(%this, %scenegraph){
    $rightPlayer = %this;

    moveMap.bindCmd(keyboard, "i", "rightPlayerUp();", "rightPlayerUpStop();");
    moveMap.bindCmd(keyboard, "l", "rightPlayerright();", "rightPlayerrightStop();");
    moveMap.bindCmd(keyboard, "k", "rightPlayerDown();", "rightPlayerDownStop();");
    moveMap.bindCmd(keyboard, "j", "rightPlayerLeft();", "rightPlayerLeftStop();");
}

function rightPlayerUp() {    
    $rightPlayer.setLinearVelocityY( -$rightPlayer.rvspeed ); 
} 
 
function rightPlayerDown() {    
    $rightPlayer.setLinearVelocityY( $rightPlayer.rvspeed ); 
} 
 
function rightPlayerLeft() {   
    $rightPlayer.setLinearVelocityX( -$rightPlayer.rhspeed ); 
} 
 
function rightPlayerRight() {     
    $rightPlayer.setLinearVelocityX( $rightPlayer.rhspeed ); 
} 
 
function rightPlayerUpStop() {    
    $rightPlayer.setLinearVelocityY( 0 ); 
} 
 
function rightPlayerDownStop() {    
    $rightPlayer.setLinearVelocityY( 0 ); 
} 
 
function rightPlayerLeftStop(){
    $rightPlayer.setLinearVelocityX( 0 ); 
} 
 
function rightPlayerRightStop() {    
    $rightPlayer.setLinearVelocityX( 0 ); 
}