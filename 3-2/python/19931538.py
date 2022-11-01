import csv
import matplotlib.pyplot as plt
import numpy as np

def str_to_int(arr):
  return list(map(int,arr))

hyendae = {
  "coach" : '강성형',
  "player" : [
    {
      "number":1,
      "name" : '정시영', 
      "position" : 'center'
    },
    {
      "number":2,
      "name" : '황윤성', 
      "position" : 'left'
    },
    {
      "number":3,
      "name" : '김다인', 
      "position" : 'setter'
    },
    {
      "number":4,
      "name" : '황연주', 
      "position" : 'right'
    },
    {
      "number":5,
      "name" : '이영주', 
      "position" : 'libero'
    },
    {
      "number":6,
      "name" : '이나연', 
      "position" : 'setter'
    },
  ]
}
insam = {
  "coach" : '이형택',
  "player" : [
    {
      "number":7,
      "name" : '고민지', 
      "position" : 'left'
    },
    {
      "number":8,
      "name" : '나현수', 
      "position" : 'center'
    },
    {
      "number":9,
      "name" : '서유경', 
      "position" : 'libero'
    },
    {
      "number":11,
      "name" : '박혜민', 
      "position" : 'left'
    },
    {
      "number":12,
      "name" : '한송이', 
      "position" : 'center'
    },
    {
      "number":13,
      "name" : '옐레나', 
      "position" : 'right'
    },
  ]
}
gs = {
  "coach" : '차상현',
  "player" : [
    {
      "number":14,
      "name" : '김지원', 
      "position" : 'setter'
    },
    {
      "number":15,
      "name" : '문명화', 
      "position" : 'center'
    },
    {
      "number":16,
      "name" : '김유리', 
      "position" : 'center'
    },
    {
      "number":17,
      "name" : '문지윤', 
      "position" : 'right'
    },
    {
      "number":18,
      "name" : '권민지', 
      "position" : 'left'
    },
    {
      "number":19,
      "name" : '유서연', 
      "position" : 'left'
    },
  ]
}
doro = {
  "coach" : '김종민',
  "player" : [
    {
      "number":20,
      "name" : '이예담', 
      "position" : 'center'
    },
    {
      "number":1,
      "name" : '배유나', 
      "position" : 'center'
    },
    {
      "number":2,
      "name" : '안나은', 
      "position" : 'libero'
    },
    {
      "number":3,
      "name" : '안예림', 
      "position" : 'setter'
    },
    {
      "number":4,
      "name" : '전세얀', 
      "position" : 'left'
    },
    {
      "number":6,
      "name" : '이고은', 
      "position" : 'setter'
    },
  ]
}
ibk = {
  "coach" : '공백',
  "player" : [
    {
      "number":7,
      "name" : '김주향', 
      "position" : 'left'
    },
    {
      "number":8,
      "name" : '라셈', 
      "position" : 'right'
    },
    {
      "number":10,
      "name" : '구혜인', 
      "position" : 'libero'
    },
    {
      "number":11,
      "name" : '김수지', 
      "position" : 'center'
    },
    {
      "number":12,
      "name" : '박민지', 
      "position" : 'left'
    },
    {
      "number":13,
      "name" : '최정민', 
      "position" : 'center'
    },
  ]
}
hngkuk = {
  "coach" : '박미희',
  "player" : [
    {
      "number":14,
      "name" : '정윤주', 
      "position" : 'left'
    },
    {
      "number":15,
      "name" : '김채연', 
      "position" : 'center'
    },
    {
      "number":17,
      "name" : '현무린', 
      "position" : 'libero'
    },
    {
      "number":18,
      "name" : '김다솔', 
      "position" : 'setter'
    },
    {
      "number":20,
      "name" : '박수연', 
      "position" : 'left'
    },
    {
      "number":1,
      "name" : '김다은', 
      "position" : 'right'
    },
  ]
}
papper = {
  "coach" : '김형실',
  "player" : [
    {
      "number":4,
      "name" : '서채원', 
      "position" : 'center'
    },
    {
      "number":6,
      "name" : '박연화', 
      "position" : 'center'
    },
    {
      "number":8,
      "name" : '이은지', 
      "position" : 'left'
    },
    {
      "number":11,
      "name" : '최민지', 
      "position" : 'center'
    },
    {
      "number":13,
      "name" : '박은서', 
      "position" : 'left'
    },
    {
      "number":15,
      "name" : '박사랑', 
      "position" : 'center'
    },
  ]
}
teams = {'현대건설':hyendae, '인삼공사':insam, 'gs칼텍스':gs, '도로공사':doro, '기업은행':ibk, '흥국생명':hngkuk, '페퍼저축은행':papper }

def team_info():
  print("정보를 보기 원하는 팀이름을 입력하세요.")
  print("[현대건설, 인삼공사, gs칼텍스, 도로공사, 기업은행, 흥국생명, 페퍼저축은행]")

  ko = input('팀 이름 : ')
  print('ko : ', ko)
  try :
    en = teams[ko]
    print('감독 : ', en.get('coach'))
    print('선수 : ')

    for p in en.get('player'):
      print('      ', p['number'], '번 - ',p['position'],' - ', p['name'])

  except:  
    print('해당 이름의 팀은 없습니다.')

def hyeondae_info():

  f=open('현대건설득점표.csv')
  data = csv.reader(f)
  header = next(data)

  date = ['20211110','20211113','20211117','20211120', '20211126','20211203']
  kim = []
  ya = []
  hwang = []
  go = []
  lee = []

  for row in data:
    kim.append(row[0])
    ya.append(row[1])
    hwang.append(row[2])
    go.append(row[3])
    lee.append(row[4])

  kim = str_to_int(kim)
  ya = str_to_int(ya)
  hwang = str_to_int(hwang)
  go = str_to_int(go)
  lee = str_to_int(lee)
  print(kim)
  x = np.arange(len(date))  # the label locations

  fig, ax = plt.subplots()
  rects1 = ax.bar(x-0.36, kim, 0.18, label=header[0])
  rects2 = ax.bar(x-0.18, ya, 0.18, label=header[1])
  rects3 = ax.bar(x, hwang, 0.18, label=header[2])
  rects4 = ax.bar(x+0.18, go, 0.18, label=header[3])
  rects5 = ax.bar(x+0.36, lee, 0.18, label=header[4])


  ax.set_ylabel('Scores')
  ax.set_title('Score')
  ax.set_xticks(x, date)
  ax.legend()

  fig.tight_layout()

  plt.show()

  f.close()


# print("정보를 보기 원하는 팀이름을 입력하세요.")
# print("[현대건설, 인삼공사, gs칼텍스, 도로공사, 기업은행, 흥국생명, 페퍼저축은행]")

# ko = input('팀 이름 : ')
# print('ko : ', ko)

# try : 
#   en = teams[ko]
#   print('감독 : ', en.get('coach'))
#   print('선수 : ')

#   for p in en.get('player'):
#     print('      ', p['number'], '번 - ',p['position'],' - ', p['name'])

  

# except:
#   print('해당 이름의 팀은 없습니다.')

team_info()

check = input('다른 팀의 정보를 확인 하시겠습니까? y/n')

if check == 'y':
  team_info()
else :
  print('현대건설 선수들의 득점을 차트로 확인합니다.')
  hyeondae_info()