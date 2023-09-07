create database AntriebsRaetsel;

-- Use the AntriebsRaetsel database
USE AntriebsRaetsel;

TRUNCATE AntriebsRaetsel.answers;
TRUNCATE AntriebsRaetsel.questions;
TRUNCATE AntriebsRaetsel.scores;

-- Insert test data for 20 different people into SCORES table
INSERT INTO SCORES (QUESTION_ID, PLAYER_NAME, SCORE)
VALUES
    (1, 'Player1', 100),
    (2, 'Player2', 85),
    (3, 'Player3', 120),
    (4, 'Player4', 95),
    (5, 'Player5', 110),
    (6, 'Player6', 75),
    (7, 'Player7', 130),
    (8, 'Player8', 70),
    (9, 'Player9', 105),
    (10, 'Player10', 80),
    (11, 'Player11', 115),
    (12, 'Player12', 90),
    (13, 'Player13', 125),
    (14, 'Player14', 65),
    (15, 'Player15', 140),
    (16, 'Player16', 55),
    (17, 'Player17', 135),
    (18, 'Player18', 75),
    (19, 'Player19', 100),
    (20, 'Player20', 120);

-- Insert test questions into QUESTIONS table
INSERT INTO QUESTIONS (QUESTION_ID, QUESTION_TEXT)
VALUES
    (1, 'What''s the name of the first player?'),
    (2, 'What is the capital of France?'),
    (3, 'How many continents are there?'),
    (4, 'Who wrote the play "Romeo and Juliet"?'),
    (5, 'What is the chemical symbol for gold?'),
    (6, 'Which planet is known as the Red Planet?');

-- Insert test answers for each question (5 correct and 5 incorrect) into ANSWERS table
-- Question 1 answers
INSERT INTO ANSWERS (ANSWER_ID, ANSWER_TEXT, ISCORRECT, QUESTION_ID)
VALUES
    (1, 'Player1', 1, 1),
    (2, 'Player2', 0, 1),
    (3, 'Player3', 0, 1),
    (4, 'Player4', 0, 1),
    (5, 'Player5', 0, 1),
    (6, 'Player6', 0, 1),
    (7, 'Player7', 0, 1),
    (8, 'Player8', 0, 1),
    (9, 'Player9', 0, 1),
    (10, 'Player10', 0, 1),
    -- Question 2 answers
    (11, 'Berlin', 0, 2),
    (12, 'Madrid', 0, 2),
    (13, 'Paris', 1, 2),
    (14, 'Rome', 0, 2),
    (15, 'London', 0, 2),
    (16, 'Vienna', 0, 2),
    (17, 'Athens', 0, 2),
    (18, 'Lisbon', 0, 2),
    (19, 'Amsterdam', 0, 2),
    (20, 'Brussels', 0, 2);

-- Commit the changes
COMMIT;



