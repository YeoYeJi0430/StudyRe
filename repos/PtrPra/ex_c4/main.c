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
		printf("��ȣ �Է� : ");
		scanf("%d", &number);

		switch (number)
		{
		case 1:
			printf("�й��Է� : ");
			scanf("%d", &(ps.num));
			printf("�������� : ");
			scanf("%d", &(ps.math));
			printf("�������� : ");
			scanf("%d", &(ps.eng));
			break;
		case 2:
			printf("������� : ");
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
	struct Student st[10]; // �л� ���� �迭
	static int in = 0; // �л� �ε���
	int input = 0; // �Է� �ޱ�

	while (input != 5) // 5�̸� Ż��!
	{
		printf("��ȣ �Է� : ");
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
	// 10���� �л��� ���� �迭. 
	static int stdIndex = 0;
	// �л��ε����� 

	int input = 0;



	while (input != 5) {

		printf("�л��⼮���Դϴ�.\n��ȣ�� �Է����ּ���.\n");

		printf("1. �л������Է�\n");
		printf("2. �л����� ���\n");
		printf("5. ���� \n");
		scanf("%d", &input);

		if (input == 1) {

			if (stdIndex >= 9) {
				printf("�л��� ���� ����á���ϴ�.\n");
			}
			else {



				int studentNumber;
				int mathScore;
				int engScore;

				printf("�й��Է� : ");
				scanf("%d", &studentNumber); 
				printf("��������");
				scanf("%d", &mathScore);
				printf("��������");
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

				printf("�й� \t\t ���� \t\t ���� \t\t \n");
				for (i = 0; i < stdIndex; i++) {
					printf("%d \t\t %d \t\t %d \t\t\n",
						std[i].stdNum, std[i].stdMat, std[i].stdEng);
				}
			}
			else {
				printf("�л������� ����.\n");
			}
		}


	}
}