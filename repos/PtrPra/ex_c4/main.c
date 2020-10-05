#include <stdio.h>
#include <stdlib.h>

/*
struct Student
{
	int num;
	int math;
	int eng;
};

int main(void)
{
	//here.
	struct Student ps;
	int number;


	while (1)
	{
		printf("번호 입력 : ");
		scanf("%d", &number);

		switch (number)
		{
		case 1:
			printf("학번입력 : ");
			scanf("%d", &(ps.num));
			printf("수학점수 : ");
			scanf("%d", &(ps.math));
			printf("영어점수 : ");
			scanf("%d", &(ps.eng));
			break;
		case 2:
			printf("정보출력 : ");
			printf("%d\n", ps.num);
			printf("%d\n", ps.math);
			printf("%d\n", ps.eng);
			break;
		case 5:
			break;
		}
		if (number == 5) break;
	}



	system("pause");
	return EXIT_SUCCESS;
}
*/

/*
struct Student
{
	int num;
	int met;
	int eng;
};

int main(void)
{
	struct Student st[10]; // 학생 담을 배열
	static int in = 0; // 학생 인덱스
	int input = 0; // 입력 받기

	while (input != 5) // 5이면 탈출!
	{
		printf("번호 입력 : ");
		scanf("%d", in);

		if (in == 1)
		{

		}

	}

	system("pause");
	return EXIT_SUCCESS;
}
*/

struct Student {
	int stdNum;
	int stdMat;
	int stdEng;
};


void main() {


	struct Student std[10];
	// 10명의 학생을 담을 배열. 
	static int stdIndex = 0;
	// 학생인덱스값 

	int input = 0;



	while (input != 5) {

		printf("학생출석부입니다.\n번호를 입력해주세요.\n");

		printf("1. 학생정보입력\n");
		printf("2. 학생정보 출력\n");
		printf("5. 종료 \n");
		scanf("%d", &input);

		if (input == 1) {

			if (stdIndex >= 9) {
				printf("학생의 수가 가득찼습니다.\n");
			}
			else {



				int studentNumber;
				int mathScore;
				int engScore;

				printf("학번입력 : ");
				scanf("%d", &studentNumber); 
				printf("수학점수");
				scanf("%d", &mathScore);
				printf("영어점수");
				scanf("%d", &engScore);

				std[stdIndex].stdNum = studentNumber;
				std[stdIndex].stdMat = mathScore;
				std[stdIndex].stdEng = engScore;
				stdIndex++;
			}
		}
		else if (input == 2) {

			if (stdIndex > 0) {
				int i;

				printf("학번 \t\t 수학 \t\t 영어 \t\t \n");
				for (i = 0; i < stdIndex; i++) {
					printf("%d \t\t %d \t\t %d \t\t\n",
						std[i].stdNum, std[i].stdMat, std[i].stdEng);
				}
			}
			else {
				printf("학생정보가 없음.\n");
			}
		}


	}
}