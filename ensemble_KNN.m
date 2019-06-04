function acc=ensemble_KNN(y_cout,y_t,sign,sig)
tic
labelMat=zeros(140,10);
label=zeros(140,1);
for i=1:10
    if i<=8
        y_tt=[y_t(i:i+2,:);y_t(i+10:i+12,:);y_t(i+20:i+22,:);y_t(i+30:i+32,:);y_t(i+40:i+42,:);y_t(i+50:i+52,:);y_t(i+60:i+62,:)];
    else
        y_tt=[y_t(i:10,:);y_t(1:i-8,:);y_t(i+10:20,:);y_t(11:i+2,:);y_t(i+20:30,:);y_t(21:i+12,:);y_t(i+30:40,:);y_t(31:i+22,:);y_t(i+40:50,:);y_t(41:i+32,:);y_t(i+50:60,:);y_t(51:i+42,:);y_t(i+60:70,:);y_t(61:i+52,:)];
    end
    labelMat(:,i)=KNN(y_cout,y_tt,sign,1);
end
for j=1:140
    label(j)=mode(labelMat(j,:));
end
toc
x=linspace(1,140,140);
plot(x,sig,'b^','MarkerSize',4)
hold on
plot(x,label,'ro','MarkerSize',5)
grid on;
xlabel("测试数据序号")
ylabel("分类标签")
legend('实际分类标签','预测分类标签');
title('测试数据分类结果');


predict=labelMat-sig;
num=0;
for i=1:140
    if predict(i)==0
        num=num+1;
    end
end
acc=num/140;