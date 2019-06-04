clear all
clc
load("y1.mat");load("y1c.mat");load("retest1.mat");
load("y2.mat");load("y2c.mat");load("retest2.mat");
load("y3.mat");load("y3c.mat");load("retest3.mat");
load("y4.mat");load("y4c.mat");load("retest4.mat");
load("y5.mat");load("y5c.mat");load("retest5.mat");
load("y6.mat");load("y6c.mat");load("retest6.mat");
load("y7.mat");load("y7c.mat");load("retest7.mat");

y_t=[y1_t,y2_t,y3_t,y4_t,y5_t,y6_t,y7_t];
y_cout=[yc1out;yc2out;yc3out;yc4out;yc5out;yc6out;yc7out];
retest=[retest1;retest2;retest3;retest4;retest5;retest6;retest7];
y_t=y_t';
sign1=ones(80,1);sig1=ones(20,1);
sign2=2*ones(80,1);sig2=2*ones(20,1);
sign3=3*ones(80,1);sig3=3*ones(20,1);
sign4=4*ones(80,1);sig4=4*ones(20,1);
sign5=5*ones(80,1);sig5=5*ones(20,1);
sign6=6*ones(80,1);sig6=6*ones(20,1);
sign7=7*ones(80,1);sig7=7*ones(20,1);
sign=[sign1;sign2;sign3;sign4;sign5;sign6;sign7];
sig=[sig1;sig2;sig3;sig4;sig5;sig6;sig7];
y_t0=[y_t,sign];

y_c1=PAA(y_cout,100);
retest_PAA=PAA(retest,100);
%读取训练数据
%[f1,f2,f3,f4,f5,f6,f7,f8,f9,f10,f11,f12,f13,f14,f15,f16,f17,f18,f19,f20,f21,f22,f23,f24,f25,f26,f27,f28,f29,f30,f31,f32,f33,f34,f35,f36,f37,f38,f39,f40,f41,f42,f43,f44,f45,f46,f47,f48,f49,f50,f51,f52,f53,f54,f55,f56,f57,f58,f59,f60,f61,f62,f63,f64,f65,f66,f67,f68,f69,f70,f71,f72,f73,f74,f75,f76,f77,f78,f79,f80,f81,f82,f83,f84,f85,f86,f87,f88,f89,f90,f91,f92,f93,f94,f95,f96,f97,f98,f99,f100,class] = textread('DefaultTrainData.txt' , '%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f%f',560);

%特征值归一化
%[input,minI,maxI] = premnmx( [f1,f2,f3,f4,f5,f6,f7,f8,f9,f10,f11,f12,f13,f14,f15,f16,f17,f18,f19,f20,f21,f22,f23,f24,f25,f26,f27,f28,f29,f30,f31,f32,f33,f34,f35,f36,f37,f38,f39,f40,f41,f42,f43,f44,f45,f46,f47,f48,f49,f50,f51,f52,f53,f54,f55,f56,f57,f58,f59,f60,f61,f62,f63,f64,f65,f66,f67,f68,f69,f70,f71,f72,f73,f74,f75,f76,f77,f78,f79,f80,f81,f82,f83,f84,f85,f86,f87,f88,f89,f90,f91,f92,f93,f94,f95,f96,f97,f98,f99,f100]')  ;

%构造输出矩阵
s = length(sign) ;
output = zeros( s ,7  ) ;
for i = 1 : s
   output( i , sign( i )  ) = 1 ;
end

%创建神经网络
net = newff( minmax(y_t') , [20 7] , { 'logsig' 'logsig' } , 'traingd' ) ; 

%设置训练参数
net.trainparam.show = 50 ;
net.trainparam.epochs = 10000 ;
net.trainparam.goal = 0.001 ;
net.trainParam.lr = 0.01 ;

%开始训练
net = train( net, y_t' , output' ) ;

%读取测试数据
load("retest1.mat");load("retest2.mat");load("retest3.mat");load("retest4.mat");load("retest5.mat");load("retest6.mat");load("retest7.mat");
retest=[retest1;retest2;retest3;retest4;retest5;retest6;retest7];
t=PAA(retest,100);
sig1=ones(20,1);
sig2=2*ones(20,1);
sig3=3*ones(20,1);
sig4=4*ones(20,1);
sig5=5*ones(20,1);
sig6=6*ones(20,1);
sig7=7*ones(20,1);
sig=[sig1;sig2;sig3;sig4;sig5;sig6;sig7];

%测试数据归一化
% testInput = tramnmx ( [t(:,1),t(:,2),t(:,3),t(:,4),t(:,5),t(:,6),t(:,7),t(:,8),t(:,9),t(:,10),t(:,11),t(:,12),t(:,13),t(:,14),t(:,15),t(:,16),t(:,17),t(:,18),t(:,19),t(:,20),t(:,21),t(:,22),t(:,23),t(:,24),t(:,25),t(:,26),t(:,27),t(:,28),t(:,29),t(:,30),t(:,31),t(:,32),t(:,33),t(:,34),t(:,35),t(:,36),t(:,37),t(:,38),t(:,39),t(:,40),t(:,41),t(:,42),t(:,43),t(:,44),t(:,45),t(:,46),t(:,47),t(:,48),t(:,49),t(:,50),t(:,51),t(:,52),t(:,53),t(:,54),t(:,55),t(:,56),t(:,57),t(:,58),t(:,59),t(:,60),t(:,61),t(:,62),t(:,63),t(:,64),t(:,65),t(:,66),t(:,67),t(:,68),t(:,69),t(:,70),t(:,71),t(:,72),t(:,73),t(:,74),t(:,75),t(:,76),t(:,77),t(:,78),t(:,79),t(:,80),t(:,81),t(:,82),t(:,83),t(:,84),t(:,85),t(:,86),t(:,87),t(:,88),t(:,89),t(:,90),t(:,91),t(:,92),t(:,93),t(:,94),t(:,95),t(:,96),t(:,97),t(:,98),t(:,99),t(:,100)]' , minI, maxI ) ;

%仿真
Y = sim( net , retest_PAA' ) ;
[a,result]=max(Y);
x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,result,'ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果——集成算法');

predict=result'-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140

% %统计识别正确率
% [s1 , s2] = size( Y ) ;
% hitNum = 0 ;
% for i = 1 : s2
%     [m , Index] = max( Y( : ,  i ) ) ;
%     if( Index  == sig(i)   ) 
%         hitNum = hitNum + 1 ; 
%     end
% end
% sprintf('识别率是 %3.3f%%',100 * hitNum / s2 )