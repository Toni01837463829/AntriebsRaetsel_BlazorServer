create database AntriebsRaetsel;

use AntriebsRaetsel;

    
INSERT INTO SCORES (QUESTION_ID, PLAYER_NAME, SCORE) VALUE (1, 'Player1', 100);

INSERT INTO QUESTIONS (QUESTION_ID, QUESTION_TEXT) VALUE (1, 'Whats the name of the first player?');

INSERT INTO ANSWERS (ANSWER_ID, ANSWER_TEXT, ISCORRECT, QUESTION_ID) VALUE 
(1, 'Player1', 1, 1),
(2, 'Player2', 0, 1),
(3, 'Player3', 0, 1),
(4, 'Player4', 0, 1);

commit ;


