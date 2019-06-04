%% 清屏
clear all
clc
%% 加载数据
load("k1.mat");load("y1c.mat");
load("k2.mat");load("y2c.mat");
load("k3.mat");load("y3c.mat");
load("k4.mat");load("y4c.mat");
load("k5.mat");load("y5c.mat");
load("k6.mat");load("y6c.mat");
load("k7.mat");load("y7c.mat");

k_t=[k1_t,k2_t,k3_t,k4_t,k5_t,k6_t,k7_t];
y_cout=[yc1out;yc2out;yc3out;yc4out;yc5out;yc6out;yc7out];
k_t=k_t';
sign1=ones(3,1);sig1=ones(20,1);
sign2=2*ones(3,1);sig2=2*ones(20,1);
sign3=3*ones(3,1);sig3=3*ones(20,1);
sign4=4*ones(3,1);sig4=4*ones(20,1);
sign5=5*ones(3,1);sig5=5*ones(20,1);
sign6=6*ones(3,1);sig6=6*ones(20,1);
sign7=7*ones(3,1);sig7=7*ones(20,1);
sign=[sign1;sign2;sign3;sign4;sign5;sign6;sign7];
sig=[sig1;sig2;sig3;sig4;sig5;sig6;sig7];
%% DTW尝试
% clc
% tic
yfit3=KNN(y_cout,k_t,sign,1)';
% x=linspace(1,140,140);
% plot(x,sig,'b^','MarkerSize',4)
% hold on
% plot(x,labelMat,'ro','MarkerSize',5)
% grid on;
% xlabel("测试数据序号")
% ylabel("分类标签")
% legend('实际分类标签','预测分类标签');
% title('测试数据分类结果');
% toc
% 
% predict=labelMat-sig;
% num=0;
% for i=1:140
%     if predict(i)==0
%         num=num+1;
%     end
% end
% acc=num/140
%% 单纯KNN
yfit2=KNN_only(y_c1,y_t,sign,1)';
%% 整合
result_temp=[yfit1;yfit2;yfit3];
result=zeros(1,140);
for i=1:140
    result(i)=mode(result_temp(:,i));
end
result=result';
x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,yfit2','ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果');

predict=yfit2'-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140