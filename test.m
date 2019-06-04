%% 清屏
clear all
clc
%% 加载数据
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
%% 整体测试
[result,r1,r2,r3]=ensemble(y_cout,y_c1,y_t,sign,4,0);

%% 结果显示
x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,r3','ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果——集成学习');

predict=r3'-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140
%% 归一化
Tmax=max(max(y_t));
Tmin=min(min(y_t));
y_tg=(y_t-Tmin)/(Tmax-Tmin);
% stairs(y_tg(81,:))
%% 决策树
tree_Label=Use_C4_5(y_t',sign',y_c1',5,10);

x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,tree_Label','ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果——集成学习');

predict=tree_Label'-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140
%% 支持向量机libsvm
clc
% 
% [y_t,pstrain]=mapminmax(y_t');
% pstrain.ymin=0;
% pstrain.ymax=1;
% [y_t,pstrain]=mapminmax(y_t,pstrain);
% 
% [y_c1,pstrain]=mapminmax(y_c1');
% pstrain.ymin=0;
% pstrain.ymax=1;
% [y_c1,pstrain]=mapminmax(y_c1,pstrain);
% 
% y_t=y_t';
% y_c1=y_c1';

[bestacc,bestc,bestg] = SVMcg(sign,y_t,-2,4,-4,4,3,0.5,0.5,0.9);

cmd = ['-c ',num2str(bestc),' -g ',num2str(bestg)];
model = libsvmtrain(sign,y_t,cmd);
pre= libsvmpredict(sig,y_c1,model);

x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,pre','ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果');
%% 保存真实数据
fid = fopen('ActualData_684.txt','wt');
[m,n]=size(retest); 
for i=1:1:m 
for j=1:1:n 
if j==n 
fprintf(fid,'%g\n',retest(i,j)); 
else 
fprintf(fid,'%g\t',retest(i,j)); 
end 
end 
end 
fclose(fid);
%% 保存训练数据
fid = fopen('DefaultTrainData.txt','wt');
[m,n]=size(y_t0); 
for i=1:1:m 
for j=1:1:n 
if j==n 
fprintf(fid,'%g\n',y_t0(i,j)); 
else 
fprintf(fid,'%g\t',y_t0(i,j)); 
end 
end 
end 
fclose(fid);
%% 代码尝试
[classifier,~]=trainClassifier(y_t0);
result=classifier.predictFcn(y_c1);
%% DTW尝试
% clc
% tic
% labelMat=KNN(y_cout,y_t,sign,1);
x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,result','ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果');

predict=result'-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140
%每个分类5个样本、k=1时，准确率为89.29%,用时146.18秒
%每个分类2个样本、k=1时，准确率为81.43%,用时64.66秒
%每个分类5个样本、k=3时，准确率为80.71%
%每个分类5个样本、k=5时，准确率为77.86%

%% PCA降维
% [COEFF,SCORE,latent,tsquare] = pca(y_t);
% test1=cumsum(latent)./sum(latent);
% tranMatrix=COEFF(:,1:6);
% y_tf=y_t*tranMatrix;
% y_tf1=[y_tf,sign];
% 
% [COEFF,SCORE,latent,tsquare] = pca(y_c);
% tranMatrix=COEFF(:,1:6);
% y_cf=y_c*tranMatrix;
% y_cf1=[y_cf,sig];
%% KPCA降维

%% PAA降维
% y_t1=zeros(560,5);
% y_c1=zeros(140,5);
% for i=1:560
%     y_t1(i,1)=mean(y_t(i,1:20));
%     y_t1(i,2)=mean(y_t(i,21:40));
%     y_t1(i,3)=mean(y_t(i,41:60));
%     y_t1(i,4)=mean(y_t(i,61:80));
%     y_t1(i,5)=mean(y_t(i,81:100));
% end
% for i=1:140
%     y_c1(i,1)=mean(y_c(i,1:20));
%     y_c1(i,2)=mean(y_c(i,21:40));
%     y_c1(i,3)=mean(y_c(i,41:60));
%     y_c1(i,4)=mean(y_c(i,61:80));
%     y_c1(i,5)=mean(y_c(i,81:100));
% end
% sign1=ones(80,1);
% sign2=2*ones(80,1);
% sign3=3*ones(80,1);
% sign4=4*ones(80,1);
% sign5=5*ones(80,1);
% sign6=6*ones(80,1);
% sign7=7*ones(80,1);
% sign=[sign1;sign2;sign3;sign4;sign5;sign6;sign7];
% y_t11=[y_t1,sign];

%% PAA降维_2
y_c1=zeros(140,100);
for i=1:140
    for j=1:100
        y_c1(i,j)=mean(y_cout(i,1+10*(j-1):10*j));
    end
end
%% 查看结果
yfit1 = trainedModel5.predictFcn(y_c1);
yfit1=yfit1';
% x=linspace(1,140,140);
% % t=linspace(1,100,100);
% plot(x,sig,'b^','MarkerSize',4)
% hold on
% plot(x,yfit,'ro','MarkerSize',5)
% grid on;
% xlabel("测试数据序号")
% ylabel("分类标签")
% legend('实际分类标签','预测分类标签');
% title('测试数据分类结果——集成方法II');
% 
% predict=yfit'-sig;
% num=0;
% for i=1:140
%     if predict(i)==0
%         num=num+1;
%     end
% end
% acc=num/140
% stairs(t,y_ac1')
%% dfad
yfit1 = trainedModel2.predictFcn(y_c);
yfit1=yfit1';
x=linspace(1,140,140);
plot(x,yfit1,'o')
%% 集成学习
output=zeros(50,50);
output=double(output);
flag=0;
for i=1:50
    for j=1:50
        ens = fitensemble(y_t,sign,'subspace',i,'knn','NPredToSample',j,'type','classification');
        predict_label=predict(ens,y_c1);
        outsign=sig-predict_label;
        for k=1:140
            if(outsign(k)==0)
                flag=flag+1;
            end
        end
        output(i,j)=flag/140;
        flag=0;
    end
end
        
% x=linspace(1,140,140);
% plot(x,predict_label,'o')





