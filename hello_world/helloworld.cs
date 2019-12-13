using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// using = C# 키워드임 C#규격 예약된 키워드

namespace hello_world
{
    // *네임스페이스
    // 성격, 하는 일이 비슷한 형식을 하나의 이름으로 그룹화
    // .NET 프레임워크 라이브러리
    // System.IO, System.Printing

    // *네임스페이스 만들기
    //Namespace 키워드
    // {
    //클래스
    //구조체
    //등등
    // }

    class helloworld
    {
        //클래스 = C#프로그램을 구성하는 기본단위
        //데이터와 데이터 처리기능(method)

        //프로그램 실행이 시작되는곳
        static void Main(string[] args) //메소드 라고 한다
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법:HelloWorld.exe <이름>");
                return;
                //Console이라는 System에서 적용됨.
            }

            WriteLine("Hello.{0}!", args[0]);
            //원래 Console도 써야되는데 앞에서 선언해서 안해도된다
        }
    }
}

//세미콜론 (;) 문장의 끝을 나타낸다!
// using static <- 데이터 형식의 정적 멤버 사용

// Console 클래스의 대표적인 정적 멤버
// Write(), WriteLine(), Read(), ReadLine()

// C#의 주석 -> //(한줄주석), /* */(여러줄 주석) 
// 컴파일러가 주석부분은 컴파일 하지 않는다

/* 메소드
 * 
 * C프로그래밍 언어 -> 함수
 * 객체 지향 프로그래밍 -> 메서드
 * 입력(객체) -> 계산 -> 출력(객체)
 * 
 * static(한정자) void(=반환형식) Main(=메소드이름) (string[] args)(=매개 변수) {(코드블록)}
 * 진입접 (Entry Point)
 * 특별한 메소드 : Main
 * 프로그램 시작시 실행
 * Main메소드 종료 시 프로그램 종료
 * 프로그램 실행 시 매개 변수 입력
 * 
 * C# exe -> arguments(Main)메소드 실행 ->
 * 
 * if(args.Length==0) {}
 * 매개변수 입력이 필요한 프로그램
 * if문
 * 조건을 평가해 프로그램의 흐름 제어
 * 목록의 길이 검사(args.Length==0) (=입력한 매개변수가 없을때 실행)
 * 
 * Return
 * 호출자에게 메서드 실행 결과 반환
 * Main 메서드 종료
 * 
 * CLR에 대하여
 * CLR(=Common Language Runtime)
 * C#으로 만든 프로그램의 실행 환경
 * 중간언어를 통한 다중 언어 지원
 * 플랫폼 최적화된 코드 생성
 * 
 * C#코드의 여정
 * ->C# 컴파일러
 * ->IL(Intermediate Language)파일
 * ->JIT(Just In Time) 컴파일
 * CLR의 IL코드 -> 네이티브 코드 컴파일 -> 실행
 * */
